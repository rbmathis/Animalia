using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leiopelmatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leiopelmatidae.Leiopelma;

/// <summary>
/// Abstract class for Leiopelma (genus).
/// NCBI TaxId: 43507
/// </summary>
public abstract class Leiopelma : Leiopelmatidae, ILeiopelma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leiopelma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43507;

    /// <inheritdoc />
    public virtual string GenusName => "Leiopelma";

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
