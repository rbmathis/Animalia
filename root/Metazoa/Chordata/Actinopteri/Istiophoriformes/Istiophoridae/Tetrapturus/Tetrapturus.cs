using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Istiophoriformes.Istiophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Istiophoriformes.Istiophoridae.Tetrapturus;

/// <summary>
/// Abstract class for Tetrapturus (genus).
/// NCBI TaxId: 13718
/// </summary>
public abstract class Tetrapturus : Istiophoridae, ITetrapturus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tetrapturus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13718;

    /// <inheritdoc />
    public virtual string GenusName => "Tetrapturus";

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
