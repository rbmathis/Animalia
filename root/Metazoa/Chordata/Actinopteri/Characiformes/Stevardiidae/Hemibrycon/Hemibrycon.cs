using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Hemibrycon;

/// <summary>
/// Abstract class for Hemibrycon (genus).
/// NCBI TaxId: 304013
/// </summary>
public abstract class Hemibrycon : Stevardiidae, IHemibrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemibrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304013;

    /// <inheritdoc />
    public virtual string GenusName => "Hemibrycon";

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
