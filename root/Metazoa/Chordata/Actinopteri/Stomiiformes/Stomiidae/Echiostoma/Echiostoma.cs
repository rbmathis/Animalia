using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Echiostoma;

/// <summary>
/// Abstract class for Echiostoma (genus).
/// NCBI TaxId: 882825
/// </summary>
public abstract class Echiostoma : Stomiidae, IEchiostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Echiostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 882825;

    /// <inheritdoc />
    public virtual string GenusName => "Echiostoma";

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
