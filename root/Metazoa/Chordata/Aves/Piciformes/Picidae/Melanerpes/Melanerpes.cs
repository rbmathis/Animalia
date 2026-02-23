using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Melanerpes;

/// <summary>
/// Abstract class for Melanerpes (genus).
/// NCBI TaxId: 56082
/// </summary>
public abstract class Melanerpes : Picidae, IMelanerpes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanerpes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56082;

    /// <inheritdoc />
    public virtual string GenusName => "Melanerpes";

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
