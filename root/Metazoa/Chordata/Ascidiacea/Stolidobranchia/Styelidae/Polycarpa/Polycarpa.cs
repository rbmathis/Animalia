using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Polycarpa;

/// <summary>
/// Abstract class for Polycarpa (genus).
/// NCBI TaxId: 30298
/// </summary>
public abstract class Polycarpa : Styelidae, IPolycarpa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polycarpa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30298;

    /// <inheritdoc />
    public virtual string GenusName => "Polycarpa";

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
