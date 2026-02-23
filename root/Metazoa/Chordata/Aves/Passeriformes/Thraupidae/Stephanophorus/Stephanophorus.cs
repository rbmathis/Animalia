using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Stephanophorus;

/// <summary>
/// Abstract class for Stephanophorus (genus).
/// NCBI TaxId: 548514
/// </summary>
public abstract class Stephanophorus : Thraupidae, IStephanophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stephanophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 548514;

    /// <inheritdoc />
    public virtual string GenusName => "Stephanophorus";

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
