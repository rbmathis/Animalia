using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Evermannellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Evermannellidae.Odontostomops;

/// <summary>
/// Abstract class for Odontostomops (genus).
/// NCBI TaxId: 509774
/// </summary>
public abstract class Odontostomops : Evermannellidae, IOdontostomops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Odontostomops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 509774;

    /// <inheritdoc />
    public virtual string GenusName => "Odontostomops";

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
