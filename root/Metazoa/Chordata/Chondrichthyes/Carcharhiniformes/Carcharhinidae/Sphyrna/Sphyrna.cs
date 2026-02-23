using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Sphyrna;

/// <summary>
/// Abstract class for Sphyrna (genus).
/// NCBI TaxId: 7822
/// </summary>
public abstract class Sphyrna : Carcharhinidae, ISphyrna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sphyrna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7822;

    /// <inheritdoc />
    public virtual string GenusName => "Sphyrna";

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
