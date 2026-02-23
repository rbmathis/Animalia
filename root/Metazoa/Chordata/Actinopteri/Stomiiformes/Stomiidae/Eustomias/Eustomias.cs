using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Eustomias;

/// <summary>
/// Abstract class for Eustomias (genus).
/// NCBI TaxId: 882827
/// </summary>
public abstract class Eustomias : Stomiidae, IEustomias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eustomias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 882827;

    /// <inheritdoc />
    public virtual string GenusName => "Eustomias";

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
