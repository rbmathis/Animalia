using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Indoreonectes;

/// <summary>
/// Abstract class for Indoreonectes (genus).
/// NCBI TaxId: 1824550
/// </summary>
public abstract class Indoreonectes : Nemacheilidae, IIndoreonectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Indoreonectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1824550;

    /// <inheritdoc />
    public virtual string GenusName => "Indoreonectes";

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
