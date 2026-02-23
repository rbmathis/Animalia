using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Gecinulus;

/// <summary>
/// Abstract class for Gecinulus (genus).
/// NCBI TaxId: 367959
/// </summary>
public abstract class Gecinulus : Picidae, IGecinulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gecinulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 367959;

    /// <inheritdoc />
    public virtual string GenusName => "Gecinulus";

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
