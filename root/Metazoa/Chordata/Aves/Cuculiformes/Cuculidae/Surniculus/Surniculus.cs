using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Surniculus;

/// <summary>
/// Abstract class for Surniculus (genus).
/// NCBI TaxId: 78209
/// </summary>
public abstract class Surniculus : Cuculidae, ISurniculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Surniculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 78209;

    /// <inheritdoc />
    public virtual string GenusName => "Surniculus";

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
