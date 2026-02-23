using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Asterocarpa;

/// <summary>
/// Abstract class for Asterocarpa (genus).
/// NCBI TaxId: 581077
/// </summary>
public abstract class Asterocarpa : Styelidae, IAsterocarpa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Asterocarpa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 581077;

    /// <inheritdoc />
    public virtual string GenusName => "Asterocarpa";

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
