using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Homatula;

/// <summary>
/// Abstract class for Homatula (genus).
/// NCBI TaxId: 937053
/// </summary>
public abstract class Homatula : Nemacheilidae, IHomatula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Homatula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 937053;

    /// <inheritdoc />
    public virtual string GenusName => "Homatula";

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
