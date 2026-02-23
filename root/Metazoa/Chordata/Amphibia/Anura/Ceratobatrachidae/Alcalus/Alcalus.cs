using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratobatrachidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratobatrachidae.Alcalus;

/// <summary>
/// Abstract class for Alcalus (genus).
/// NCBI TaxId: 1795275
/// </summary>
public abstract class Alcalus : Ceratobatrachidae, IAlcalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alcalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1795275;

    /// <inheritdoc />
    public virtual string GenusName => "Alcalus";

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
