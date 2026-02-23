using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Leptosittaca;

/// <summary>
/// Abstract class for Leptosittaca (genus).
/// NCBI TaxId: 503989
/// </summary>
public abstract class Leptosittaca : Psittacidae, ILeptosittaca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptosittaca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 503989;

    /// <inheritdoc />
    public virtual string GenusName => "Leptosittaca";

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
