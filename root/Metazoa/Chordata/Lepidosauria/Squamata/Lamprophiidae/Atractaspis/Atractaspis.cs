using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Atractaspis;

/// <summary>
/// Abstract class for Atractaspis (genus).
/// NCBI TaxId: 8599
/// </summary>
public abstract class Atractaspis : Lamprophiidae, IAtractaspis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atractaspis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8599;

    /// <inheritdoc />
    public virtual string GenusName => "Atractaspis";

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
