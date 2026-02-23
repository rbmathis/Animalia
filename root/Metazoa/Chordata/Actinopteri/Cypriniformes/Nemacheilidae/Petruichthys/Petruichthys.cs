using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Petruichthys;

/// <summary>
/// Abstract class for Petruichthys (genus).
/// NCBI TaxId: 1758140
/// </summary>
public abstract class Petruichthys : Nemacheilidae, IPetruichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petruichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1758140;

    /// <inheritdoc />
    public virtual string GenusName => "Petruichthys";

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
