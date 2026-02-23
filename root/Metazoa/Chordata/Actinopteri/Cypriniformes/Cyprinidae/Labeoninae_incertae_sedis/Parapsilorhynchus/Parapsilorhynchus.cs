using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeoninae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeoninae_incertae_sedis.Parapsilorhynchus;

/// <summary>
/// Abstract class for Parapsilorhynchus (genus).
/// NCBI TaxId: 1158426
/// </summary>
public abstract class Parapsilorhynchus : Labeoninae_incertae_sedis, IParapsilorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parapsilorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1158426;

    /// <inheritdoc />
    public virtual string GenusName => "Parapsilorhynchus";

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
