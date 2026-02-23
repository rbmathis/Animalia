using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Acanthodoras;

/// <summary>
/// Abstract class for Acanthodoras (genus).
/// NCBI TaxId: 238642
/// </summary>
public abstract class Acanthodoras : Doradidae, IAcanthodoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthodoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238642;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthodoras";

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
