using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Trimmatom;

/// <summary>
/// Abstract class for Trimmatom (genus).
/// NCBI TaxId: 512337
/// </summary>
public abstract class Trimmatom : Gobiidae, ITrimmatom
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trimmatom";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 512337;

    /// <inheritdoc />
    public virtual string GenusName => "Trimmatom";

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
