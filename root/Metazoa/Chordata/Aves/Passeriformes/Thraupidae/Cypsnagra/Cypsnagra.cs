using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Cypsnagra;

/// <summary>
/// Abstract class for Cypsnagra (genus).
/// NCBI TaxId: 62186
/// </summary>
public abstract class Cypsnagra : Thraupidae, ICypsnagra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cypsnagra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62186;

    /// <inheritdoc />
    public virtual string GenusName => "Cypsnagra";

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
