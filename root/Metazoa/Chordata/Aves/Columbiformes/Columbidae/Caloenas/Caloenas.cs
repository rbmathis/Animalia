using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Caloenas;

/// <summary>
/// Abstract class for Caloenas (genus).
/// NCBI TaxId: 187105
/// </summary>
public abstract class Caloenas : Columbidae, ICaloenas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caloenas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187105;

    /// <inheritdoc />
    public virtual string GenusName => "Caloenas";

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
