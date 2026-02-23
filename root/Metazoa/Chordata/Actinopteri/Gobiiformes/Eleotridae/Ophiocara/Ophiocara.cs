using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Ophiocara;

/// <summary>
/// Abstract class for Ophiocara (genus).
/// NCBI TaxId: 86247
/// </summary>
public abstract class Ophiocara : Eleotridae, IOphiocara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ophiocara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86247;

    /// <inheritdoc />
    public virtual string GenusName => "Ophiocara";

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
