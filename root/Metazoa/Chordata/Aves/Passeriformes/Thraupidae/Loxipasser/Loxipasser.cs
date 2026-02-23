using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Loxipasser;

/// <summary>
/// Abstract class for Loxipasser (genus).
/// NCBI TaxId: 200195
/// </summary>
public abstract class Loxipasser : Thraupidae, ILoxipasser
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Loxipasser";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 200195;

    /// <inheritdoc />
    public virtual string GenusName => "Loxipasser";

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
