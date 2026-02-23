using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Flagellostomias;

/// <summary>
/// Abstract class for Flagellostomias (genus).
/// NCBI TaxId: 882832
/// </summary>
public abstract class Flagellostomias : Stomiidae, IFlagellostomias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Flagellostomias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 882832;

    /// <inheritdoc />
    public virtual string GenusName => "Flagellostomias";

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
