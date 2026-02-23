using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Glenoglossa;

/// <summary>
/// Abstract class for Glenoglossa (genus).
/// NCBI TaxId: 3040450
/// </summary>
public abstract class Glenoglossa : Ophichthidae, IGlenoglossa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glenoglossa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3040450;

    /// <inheritdoc />
    public virtual string GenusName => "Glenoglossa";

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
