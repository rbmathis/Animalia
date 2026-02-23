using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Myrophis;

/// <summary>
/// Abstract class for Myrophis (genus).
/// NCBI TaxId: 182418
/// </summary>
public abstract class Myrophis : Ophichthidae, IMyrophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myrophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182418;

    /// <inheritdoc />
    public virtual string GenusName => "Myrophis";

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
