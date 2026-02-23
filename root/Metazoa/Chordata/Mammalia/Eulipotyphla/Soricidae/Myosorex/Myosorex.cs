using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Myosorex;

/// <summary>
/// Abstract class for Myosorex (genus).
/// NCBI TaxId: 150083
/// </summary>
public abstract class Myosorex : Soricidae, IMyosorex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myosorex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 150083;

    /// <inheritdoc />
    public virtual string GenusName => "Myosorex";

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
