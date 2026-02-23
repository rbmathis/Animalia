using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Microdesmus;

/// <summary>
/// Abstract class for Microdesmus (genus).
/// NCBI TaxId: 166771
/// </summary>
public abstract class Microdesmus : Gobiidae, IMicrodesmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microdesmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 166771;

    /// <inheritdoc />
    public virtual string GenusName => "Microdesmus";

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
