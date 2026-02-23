using AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Elseya;

/// <summary>
/// Abstract class for Elseya (genus).
/// NCBI TaxId: 44496
/// </summary>
public abstract class Elseya : Chelidae, IElseya
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elseya";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44496;

    /// <inheritdoc />
    public virtual string GenusName => "Elseya";

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
