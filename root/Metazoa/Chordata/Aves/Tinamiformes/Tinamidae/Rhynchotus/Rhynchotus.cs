using AnimalKingdom.root.Metazoa.Chordata.Aves.Tinamiformes.Tinamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Tinamiformes.Tinamidae.Rhynchotus;

/// <summary>
/// Abstract class for Rhynchotus (genus).
/// NCBI TaxId: 30465
/// </summary>
public abstract class Rhynchotus : Tinamidae, IRhynchotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhynchotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30465;

    /// <inheritdoc />
    public virtual string GenusName => "Rhynchotus";

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
