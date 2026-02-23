using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Leptojulis;

/// <summary>
/// Abstract class for Leptojulis (genus).
/// NCBI TaxId: 241315
/// </summary>
public abstract class Leptojulis : Labridae, ILeptojulis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptojulis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241315;

    /// <inheritdoc />
    public virtual string GenusName => "Leptojulis";

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
