using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Distomus;

/// <summary>
/// Abstract class for Distomus (genus).
/// NCBI TaxId: 581067
/// </summary>
public abstract class Distomus : Styelidae, IDistomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Distomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 581067;

    /// <inheritdoc />
    public virtual string GenusName => "Distomus";

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
