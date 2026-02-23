using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae.Atticora;

/// <summary>
/// Abstract class for Atticora (genus).
/// NCBI TaxId: 72868
/// </summary>
public abstract class Atticora : Hirundinidae, IAtticora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atticora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 72868;

    /// <inheritdoc />
    public virtual string GenusName => "Atticora";

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
