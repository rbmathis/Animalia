using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Polyandrocarpa;

/// <summary>
/// Abstract class for Polyandrocarpa (genus).
/// NCBI TaxId: 7722
/// </summary>
public abstract class Polyandrocarpa : Styelidae, IPolyandrocarpa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polyandrocarpa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7722;

    /// <inheritdoc />
    public virtual string GenusName => "Polyandrocarpa";

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
