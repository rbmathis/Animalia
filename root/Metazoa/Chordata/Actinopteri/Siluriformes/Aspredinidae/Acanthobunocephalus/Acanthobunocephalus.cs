using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae.Acanthobunocephalus;

/// <summary>
/// Abstract class for Acanthobunocephalus (genus).
/// NCBI TaxId: 2175997
/// </summary>
public abstract class Acanthobunocephalus : Aspredinidae, IAcanthobunocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthobunocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2175997;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthobunocephalus";

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
