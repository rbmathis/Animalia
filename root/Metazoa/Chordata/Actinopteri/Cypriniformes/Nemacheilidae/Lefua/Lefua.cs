using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Lefua;

/// <summary>
/// Abstract class for Lefua (genus).
/// NCBI TaxId: 149981
/// </summary>
public abstract class Lefua : Nemacheilidae, ILefua
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lefua";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 149981;

    /// <inheritdoc />
    public virtual string GenusName => "Lefua";

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
