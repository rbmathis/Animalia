using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Photostomias;

/// <summary>
/// Abstract class for Photostomias (genus).
/// NCBI TaxId: 882870
/// </summary>
public abstract class Photostomias : Stomiidae, IPhotostomias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Photostomias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 882870;

    /// <inheritdoc />
    public virtual string GenusName => "Photostomias";

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
