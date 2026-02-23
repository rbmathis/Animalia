using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Istiophoriformes.Istiophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Istiophoriformes.Istiophoridae.Kajikia;

/// <summary>
/// Abstract class for Kajikia (genus).
/// NCBI TaxId: 1094710
/// </summary>
public abstract class Kajikia : Istiophoridae, IKajikia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kajikia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1094710;

    /// <inheritdoc />
    public virtual string GenusName => "Kajikia";

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
