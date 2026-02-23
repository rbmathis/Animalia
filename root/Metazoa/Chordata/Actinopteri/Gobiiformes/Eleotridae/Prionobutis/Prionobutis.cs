using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Prionobutis;

/// <summary>
/// Abstract class for Prionobutis (genus).
/// NCBI TaxId: 1365712
/// </summary>
public abstract class Prionobutis : Eleotridae, IPrionobutis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prionobutis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1365712;

    /// <inheritdoc />
    public virtual string GenusName => "Prionobutis";

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
