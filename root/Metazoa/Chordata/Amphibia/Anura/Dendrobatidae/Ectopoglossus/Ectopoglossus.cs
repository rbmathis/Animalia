using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Ectopoglossus;

/// <summary>
/// Abstract class for Ectopoglossus (genus).
/// NCBI TaxId: 2040453
/// </summary>
public abstract class Ectopoglossus : Dendrobatidae, IEctopoglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ectopoglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2040453;

    /// <inheritdoc />
    public virtual string GenusName => "Ectopoglossus";

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
