using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae.Fratercula;

/// <summary>
/// Abstract class for Fratercula (genus).
/// NCBI TaxId: 28700
/// </summary>
public abstract class Fratercula : Alcidae, IFratercula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fratercula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28700;

    /// <inheritdoc />
    public virtual string GenusName => "Fratercula";

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
