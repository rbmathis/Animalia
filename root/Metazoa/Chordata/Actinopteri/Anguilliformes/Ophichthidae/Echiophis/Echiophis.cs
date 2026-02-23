using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Echiophis;

/// <summary>
/// Abstract class for Echiophis (genus).
/// NCBI TaxId: 54919
/// </summary>
public abstract class Echiophis : Ophichthidae, IEchiophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Echiophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54919;

    /// <inheritdoc />
    public virtual string GenusName => "Echiophis";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
