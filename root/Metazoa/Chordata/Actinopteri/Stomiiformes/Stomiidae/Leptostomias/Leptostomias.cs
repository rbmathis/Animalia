using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Leptostomias;

/// <summary>
/// Abstract class for Leptostomias (genus).
/// NCBI TaxId: 882838
/// </summary>
public abstract class Leptostomias : Stomiidae, ILeptostomias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptostomias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 882838;

    /// <inheritdoc />
    public virtual string GenusName => "Leptostomias";

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
