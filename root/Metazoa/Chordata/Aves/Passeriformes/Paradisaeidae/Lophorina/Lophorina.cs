using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae.Lophorina;

/// <summary>
/// Abstract class for Lophorina (genus).
/// NCBI TaxId: 39957
/// </summary>
public abstract class Lophorina : Paradisaeidae, ILophorina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophorina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39957;

    /// <inheritdoc />
    public virtual string GenusName => "Lophorina";

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
