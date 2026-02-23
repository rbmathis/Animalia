using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Dendrodoa;

/// <summary>
/// Abstract class for Dendrodoa (genus).
/// NCBI TaxId: 30294
/// </summary>
public abstract class Dendrodoa : Styelidae, IDendrodoa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dendrodoa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30294;

    /// <inheritdoc />
    public virtual string GenusName => "Dendrodoa";

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
