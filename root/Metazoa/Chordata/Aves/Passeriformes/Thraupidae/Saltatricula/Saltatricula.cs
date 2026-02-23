using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Saltatricula;

/// <summary>
/// Abstract class for Saltatricula (genus).
/// NCBI TaxId: 137210
/// </summary>
public abstract class Saltatricula : Thraupidae, ISaltatricula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Saltatricula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 137210;

    /// <inheritdoc />
    public virtual string GenusName => "Saltatricula";

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
