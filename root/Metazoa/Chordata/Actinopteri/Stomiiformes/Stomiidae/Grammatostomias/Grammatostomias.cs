using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Grammatostomias;

/// <summary>
/// Abstract class for Grammatostomias (genus).
/// NCBI TaxId: 882834
/// </summary>
public abstract class Grammatostomias : Stomiidae, IGrammatostomias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grammatostomias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 882834;

    /// <inheritdoc />
    public virtual string GenusName => "Grammatostomias";

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
