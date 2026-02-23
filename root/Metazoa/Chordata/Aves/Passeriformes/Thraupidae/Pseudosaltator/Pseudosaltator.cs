using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Pseudosaltator;

/// <summary>
/// Abstract class for Pseudosaltator (genus).
/// NCBI TaxId: 3150848
/// </summary>
public abstract class Pseudosaltator : Thraupidae, IPseudosaltator
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudosaltator";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150848;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudosaltator";

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
