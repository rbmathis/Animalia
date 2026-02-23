using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Pipraeidea;

/// <summary>
/// Abstract class for Pipraeidea (genus).
/// NCBI TaxId: 62235
/// </summary>
public abstract class Pipraeidea : Thraupidae, IPipraeidea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pipraeidea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62235;

    /// <inheritdoc />
    public virtual string GenusName => "Pipraeidea";

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
