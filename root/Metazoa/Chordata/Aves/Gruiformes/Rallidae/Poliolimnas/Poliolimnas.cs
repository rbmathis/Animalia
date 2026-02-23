using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Poliolimnas;

/// <summary>
/// Abstract class for Poliolimnas (genus).
/// NCBI TaxId: 2823183
/// </summary>
public abstract class Poliolimnas : Rallidae, IPoliolimnas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poliolimnas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2823183;

    /// <inheritdoc />
    public virtual string GenusName => "Poliolimnas";

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
