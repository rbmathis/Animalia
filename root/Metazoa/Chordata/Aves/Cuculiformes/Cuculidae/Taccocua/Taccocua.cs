using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Taccocua;

/// <summary>
/// Abstract class for Taccocua (genus).
/// NCBI TaxId: 3054340
/// </summary>
public abstract class Taccocua : Cuculidae, ITaccocua
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Taccocua";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3054340;

    /// <inheritdoc />
    public virtual string GenusName => "Taccocua";

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
