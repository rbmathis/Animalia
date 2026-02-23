using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthisittidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthisittidae.Traversia;

/// <summary>
/// Abstract class for Traversia (genus).
/// NCBI TaxId: 1860147
/// </summary>
public abstract class Traversia : Acanthisittidae, ITraversia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Traversia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1860147;

    /// <inheritdoc />
    public virtual string GenusName => "Traversia";

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
