using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Epigonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Epigonidae.Brephostoma;

/// <summary>
/// Abstract class for Brephostoma (genus).
/// NCBI TaxId: 2893517
/// </summary>
public abstract class Brephostoma : Epigonidae, IBrephostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brephostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2893517;

    /// <inheritdoc />
    public virtual string GenusName => "Brephostoma";

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
