using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Dendropicos;

/// <summary>
/// Abstract class for Dendropicos (genus).
/// NCBI TaxId: 165735
/// </summary>
public abstract class Dendropicos : Picidae, IDendropicos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dendropicos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 165735;

    /// <inheritdoc />
    public virtual string GenusName => "Dendropicos";

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
