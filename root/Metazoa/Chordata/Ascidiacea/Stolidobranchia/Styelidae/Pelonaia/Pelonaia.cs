using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Pelonaia;

/// <summary>
/// Abstract class for Pelonaia (genus).
/// NCBI TaxId: 30296
/// </summary>
public abstract class Pelonaia : Styelidae, IPelonaia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pelonaia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30296;

    /// <inheritdoc />
    public virtual string GenusName => "Pelonaia";

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
