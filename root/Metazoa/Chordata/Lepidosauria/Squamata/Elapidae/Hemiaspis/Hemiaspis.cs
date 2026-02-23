using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Hemiaspis;

/// <summary>
/// Abstract class for Hemiaspis (genus).
/// NCBI TaxId: 355695
/// </summary>
public abstract class Hemiaspis : Elapidae, IHemiaspis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemiaspis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 355695;

    /// <inheritdoc />
    public virtual string GenusName => "Hemiaspis";

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
