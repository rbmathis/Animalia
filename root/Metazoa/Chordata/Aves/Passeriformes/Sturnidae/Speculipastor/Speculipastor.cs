using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Speculipastor;

/// <summary>
/// Abstract class for Speculipastor (genus).
/// NCBI TaxId: 451438
/// </summary>
public abstract class Speculipastor : Sturnidae, ISpeculipastor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Speculipastor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 451438;

    /// <inheritdoc />
    public virtual string GenusName => "Speculipastor";

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
