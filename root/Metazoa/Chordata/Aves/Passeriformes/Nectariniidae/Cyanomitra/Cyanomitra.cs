using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae.Cyanomitra;

/// <summary>
/// Abstract class for Cyanomitra (genus).
/// NCBI TaxId: 530139
/// </summary>
public abstract class Cyanomitra : Nectariniidae, ICyanomitra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyanomitra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 530139;

    /// <inheritdoc />
    public virtual string GenusName => "Cyanomitra";

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
