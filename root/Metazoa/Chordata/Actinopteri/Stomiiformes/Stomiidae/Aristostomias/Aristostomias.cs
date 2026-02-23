using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Aristostomias;

/// <summary>
/// Abstract class for Aristostomias (genus).
/// NCBI TaxId: 319439
/// </summary>
public abstract class Aristostomias : Stomiidae, IAristostomias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aristostomias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 319439;

    /// <inheritdoc />
    public virtual string GenusName => "Aristostomias";

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
